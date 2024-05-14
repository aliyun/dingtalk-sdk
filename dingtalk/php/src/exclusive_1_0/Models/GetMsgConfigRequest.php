<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigRequest\listDynamicAttr;
use AlibabaCloud\Tea\Model;

class GetMsgConfigRequest extends Model
{
    /**
     * @var string
     */
    public $groupTopic;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var listDynamicAttr[]
     */
    public $listDynamicAttr;

    /**
     * @var string[]
     */
    public $listEmployeeCode;

    /**
     * @var int[]
     */
    public $listUnitId;

    /**
     * @var string
     */
    public $ownerJobNo;

    /**
     * @var string
     */
    public $ruleBusinessCode;

    /**
     * @var int
     */
    public $ruleCategory;

    /**
     * @var string
     */
    public $ruleCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $secretKey;

    /**
     * @var string
     */
    public $sysCode;
    protected $_name = [
        'groupTopic'       => 'groupTopic',
        'groupType'        => 'groupType',
        'listDynamicAttr'  => 'listDynamicAttr',
        'listEmployeeCode' => 'listEmployeeCode',
        'listUnitId'       => 'listUnitId',
        'ownerJobNo'       => 'ownerJobNo',
        'ruleBusinessCode' => 'ruleBusinessCode',
        'ruleCategory'     => 'ruleCategory',
        'ruleCode'         => 'ruleCode',
        'secretKey'        => 'secretKey',
        'sysCode'          => 'sysCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupTopic) {
            $res['groupTopic'] = $this->groupTopic;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->listDynamicAttr) {
            $res['listDynamicAttr'] = [];
            if (null !== $this->listDynamicAttr && \is_array($this->listDynamicAttr)) {
                $n = 0;
                foreach ($this->listDynamicAttr as $item) {
                    $res['listDynamicAttr'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->listEmployeeCode) {
            $res['listEmployeeCode'] = $this->listEmployeeCode;
        }
        if (null !== $this->listUnitId) {
            $res['listUnitId'] = $this->listUnitId;
        }
        if (null !== $this->ownerJobNo) {
            $res['ownerJobNo'] = $this->ownerJobNo;
        }
        if (null !== $this->ruleBusinessCode) {
            $res['ruleBusinessCode'] = $this->ruleBusinessCode;
        }
        if (null !== $this->ruleCategory) {
            $res['ruleCategory'] = $this->ruleCategory;
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }
        if (null !== $this->sysCode) {
            $res['sysCode'] = $this->sysCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMsgConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupTopic'])) {
            $model->groupTopic = $map['groupTopic'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['listDynamicAttr'])) {
            if (!empty($map['listDynamicAttr'])) {
                $model->listDynamicAttr = [];
                $n                      = 0;
                foreach ($map['listDynamicAttr'] as $item) {
                    $model->listDynamicAttr[$n++] = null !== $item ? listDynamicAttr::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['listEmployeeCode'])) {
            if (!empty($map['listEmployeeCode'])) {
                $model->listEmployeeCode = $map['listEmployeeCode'];
            }
        }
        if (isset($map['listUnitId'])) {
            if (!empty($map['listUnitId'])) {
                $model->listUnitId = $map['listUnitId'];
            }
        }
        if (isset($map['ownerJobNo'])) {
            $model->ownerJobNo = $map['ownerJobNo'];
        }
        if (isset($map['ruleBusinessCode'])) {
            $model->ruleBusinessCode = $map['ruleBusinessCode'];
        }
        if (isset($map['ruleCategory'])) {
            $model->ruleCategory = $map['ruleCategory'];
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }
        if (isset($map['sysCode'])) {
            $model->sysCode = $map['sysCode'];
        }

        return $model;
    }
}
