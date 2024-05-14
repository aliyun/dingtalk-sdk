<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaOrgCarbonRequest;

use AlibabaCloud\Tea\Model;

class orgDetailsList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 12320211126
     *
     * @var string
     */
    public $actionId;

    /**
     * @description This parameter is required.
     *
     * @example 2021-11-26 10:09:37
     *
     * @var string
     */
    public $actionTime;

    /**
     * @description This parameter is required.
     *
     * @example VIDEO
     *
     * @var string
     */
    public $actionType;

    /**
     * @description This parameter is required.
     *
     * @example 3.21
     *
     * @var string
     */
    public $carbonAmount;

    /**
     * @description This parameter is required.
     *
     * @example ding12344
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'actionId'     => 'actionId',
        'actionTime'   => 'actionTime',
        'actionType'   => 'actionType',
        'carbonAmount' => 'carbonAmount',
        'corpId'       => 'corpId',
        'deptId'       => 'deptId',
        'version'      => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->carbonAmount) {
            $res['carbonAmount'] = $this->carbonAmount;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgDetailsList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionId'])) {
            $model->actionId = $map['actionId'];
        }
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['carbonAmount'])) {
            $model->carbonAmount = $map['carbonAmount'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
