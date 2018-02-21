/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2018 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace com.clover.sdk.v3.customers {


public class Customer {

  /// <summary>
  /// Unique identifier
  /// </summary>
  public String id { get; set; }

  /// <summary>
  /// The order with which the customer is associated
  /// </summary>
  public com.clover.sdk.v3.base_.Reference orderRef { get; set; }

  /// <summary>
  /// First/given name of the customer
  /// </summary>
  public String firstName { get; set; }

  /// <summary>
  /// Last name/surname of the customer
  /// </summary>
  public String lastName { get; set; }

  public Boolean marketingAllowed { get; set; }

  public Int64 customerSince { get; set; }

  public List<com.clover.sdk.v3.base_.Reference> orders { get; set; }

  public List<com.clover.sdk.v3.customers.Address> addresses { get; set; }

  public List<com.clover.sdk.v3.customers.EmailAddress> emailAddresses { get; set; }

  public List<com.clover.sdk.v3.customers.PhoneNumber> phoneNumbers { get; set; }

  public List<com.clover.sdk.v3.customers.Card> cards { get; set; }

}

}