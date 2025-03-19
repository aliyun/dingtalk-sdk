<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest;

use AlibabaCloud\Tea\Model;

class queryCustomer extends Model
{
    /**
     * @var string[]
     */
    public $openContactIds;

    /**
     * @example AIMED
     *
     * @var string
     */
    public $queryType;

    /**
     * @example {}
     *
     * @var string
     */
    public $searchContactConditions;

    /**
     * @example {}
     *
     * @var string
     */
    public $searchCustomerConditions;
    protected $_name = [
        'openContactIds' => 'openContactIds',
        'queryType' => 'queryType',
        'searchContactConditions' => 'searchContactConditions',
        'searchCustomerConditions' => 'searchCustomerConditions',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openContactIds) {
            $res['openContactIds'] = $this->openContactIds;
        }
        if (null !== $this->queryType) {
            $res['queryType'] = $this->queryType;
        }
        if (null !== $this->searchContactConditions) {
            $res['searchContactConditions'] = $this->searchContactConditions;
        }
        if (null !== $this->searchCustomerConditions) {
            $res['searchCustomerConditions'] = $this->searchCustomerConditions;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return queryCustomer
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openContactIds'])) {
            if (!empty($map['openContactIds'])) {
                $model->openContactIds = $map['openContactIds'];
            }
        }
        if (isset($map['queryType'])) {
            $model->queryType = $map['queryType'];
        }
        if (isset($map['searchContactConditions'])) {
            $model->searchContactConditions = $map['searchContactConditions'];
        }
        if (isset($map['searchCustomerConditions'])) {
            $model->searchCustomerConditions = $map['searchCustomerConditions'];
        }

        return $model;
    }
}
