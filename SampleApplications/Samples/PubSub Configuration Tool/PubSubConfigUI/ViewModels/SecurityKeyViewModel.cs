﻿/* Copyright (c) 1996-2017, OPC Foundation. All rights reserved.

   The source code in this file is covered under a dual-license scenario:
     - RCL: for OPC Foundation members in good-standing
     - GPL V2: everybody else

   RCL license terms accompanied with this source code. See http://opcfoundation.org/License/RCL/1.00/

   GNU General Public License as published by the Free Software Foundation;
   version 2 of the License are accompanied with this source code. See http://opcfoundation.org/License/GPLv2

   This source code is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/


using System.Collections.ObjectModel;
using PubSubBase.Definitions;

namespace PubSubConfigurationUI.ViewModels
{
    /// <summary>
    /// view model for security key view
    /// </summary>
    public class SecurityKeyViewModel : BaseViewModel
    {
        #region Private Fields 

        private string m_currentKey;
        private uint m_currentTokenId;
        private ObservableCollection< string > m_featureKeys;
        private double m_keyLifetime;
        private string m_name = string.Empty;
        private string m_securityGroupId;
        private string m_securityPolicyUri;
        private double m_timeToNextKey;

        #endregion

        #region Constructors

        public SecurityKeyViewModel( )
        {
            FeatureKeys = new ObservableCollection< string >( );
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// defines name of security key
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set
            {
                m_name = value;
                OnPropertyChanged( "Name" );
            }
        }

        /// <summary>
        /// defines type of security policy used
        /// </summary>
        public string SecurityPolicyUri
        {
            get { return m_securityPolicyUri; }
            set
            {
                m_securityPolicyUri = value;
                OnPropertyChanged( "SecurityPolicyUri" );
            }
        }

        /// <summary>
        /// defines current token ID 
        /// </summary>
        public uint CurrentTokenId
        {
            get { return m_currentTokenId; }
            set
            {
                m_currentTokenId = value;
                OnPropertyChanged( "CurrentTokenId" );
            }
        }

        /// <summary>
        /// defines Time to next key condition
        /// </summary>
        public double TimetoNextKey
        {
            get { return m_timeToNextKey; }
            set
            {
                m_timeToNextKey = value;
                OnPropertyChanged( "TimetoNextKey" );
            }
        }

        /// <summary>
        /// defines security key life time
        /// </summary>
        public double KeyLifeTime
        {
            get { return m_keyLifetime; }
            set
            {
                m_keyLifetime = value;
                OnPropertyChanged( "KeyLifeTime" );
            }
        }

        /// <summary>
        /// defines current key of security
        /// </summary>
        public string CurrentKey
        {
            get { return m_currentKey; }
            set
            {
                Name = m_currentKey = value;

                OnPropertyChanged( "CurrentKey" );
            }
        }

        /// <summary>
        /// defines collection of Feature keys
        /// </summary>
        public ObservableCollection< string > FeatureKeys
        {
            get { return m_featureKeys; }
            set
            {
                m_featureKeys = value;
                OnPropertyChanged( "FeatureKeys" );
            }
        }

        /// <summary>
        /// defines security group id 
        /// </summary>
        public string SecurityGroupId
        {
            get { return m_securityGroupId; }
            set
            {
                m_securityGroupId = value;
                OnPropertyChanged( "SecurityGroupId" );
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to add Feature keys to List
        /// </summary>
        /// <param name="featureKey"></param>
        public void AddFeatureKeysList( string featureKey )
        {
            FeatureKeys.Add( featureKey );
        }

        /// <summary>
        /// Method to Remove selected Feature key from list.
        /// </summary>
        /// <param name="featureKey"></param>
        public void RemoveFeatureKey( string featureKey )
        {
            FeatureKeys.Remove( featureKey );
        }

        #endregion
    }
}