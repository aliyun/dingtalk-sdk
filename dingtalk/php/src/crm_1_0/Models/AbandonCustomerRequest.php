<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AbandonCustomerRequest extends Model
{
    /**
     * @var string
     */
    public $customTrackDesc;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $instanceIdList;

    /**
     * @description This parameter is required.
     *
     * @example 123123123
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string
     */
    public $optType;
    protected $_name = [
        'customTrackDesc' => 'customTrackDesc',
        'instanceIdList'  => 'instanceIdList',
        'operatorUserId'  => 'operatorUserId',
        'optType'         => 'optType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customTrackDesc) {
            $res['customTrackDesc'] = $this->customTrackDesc;
        }
        if (null !== $this->instanceIdList) {
            $res['instanceIdList'] = $this->instanceIdList;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->optType) {
            $res['optType'] = $this->optType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AbandonCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customTrackDesc'])) {
            $model->customTrackDesc = $map['customTrackDesc'];
        }
        if (isset($map['instanceIdList'])) {
            if (!empty($map['instanceIdList'])) {
                $model->instanceIdList = $map['instanceIdList'];
            }
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['optType'])) {
            $model->optType = $map['optType'];
        }

        return $model;
    }
}
