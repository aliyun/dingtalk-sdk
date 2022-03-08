<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AbandonCustomerRequest extends Model
{
    /**
     * @description 自定义动态描述
     *
     * @var string
     */
    public $customTrackDesc;

    /**
     * @description 客户实例 id 数组
     *
     * @var string[]
     */
    public $instanceIdList;

    /**
     * @description 操作人staffId，一般为企业员工
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description 释放类型：returnPool-退回公海（默认），innerAbandon-仅清除负责人
     *
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
