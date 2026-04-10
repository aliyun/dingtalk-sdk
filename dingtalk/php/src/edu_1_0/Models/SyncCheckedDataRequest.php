<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncCheckedDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://...
     *
     * @var string
     */
    public $checkJsonUrl;

    /**
     * @description This parameter is required.
     *
     * @example https:.....
     *
     * @var string
     */
    public $checkUrl;

    /**
     * @description This parameter is required.
     *
     * @example ding123...
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example ding_scan_correct_...
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'checkJsonUrl' => 'checkJsonUrl',
        'checkUrl' => 'checkUrl',
        'corpId' => 'corpId',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkJsonUrl) {
            $res['checkJsonUrl'] = $this->checkJsonUrl;
        }
        if (null !== $this->checkUrl) {
            $res['checkUrl'] = $this->checkUrl;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncCheckedDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkJsonUrl'])) {
            $model->checkJsonUrl = $map['checkJsonUrl'];
        }
        if (isset($map['checkUrl'])) {
            $model->checkUrl = $map['checkUrl'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
