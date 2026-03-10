<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCorrectingDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding8196cd122f5cc6abecb851
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dataDetail;

    /**
     * @description This parameter is required.
     *
     * @example terminate_correcting
     *
     * @var string
     */
    public $dataType;

    /**
     * @description This parameter is required.
     *
     * @example DING_SCAN_CORRECT_0***0001
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'corpId' => 'corpId',
        'dataDetail' => 'dataDetail',
        'dataType' => 'dataType',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dataDetail) {
            $res['dataDetail'] = $this->dataDetail;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCorrectingDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dataDetail'])) {
            $model->dataDetail = $map['dataDetail'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
