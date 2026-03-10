<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryEduLlmModelResponseRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding819xxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example request_xxxxxxxxxx
     *
     * @var string
     */
    public $reqId;

    /**
     * @description This parameter is required.
     *
     * @example DING_xxxxxxxxxx
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'corpId' => 'corpId',
        'reqId' => 'reqId',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->reqId) {
            $res['reqId'] = $this->reqId;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEduLlmModelResponseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['reqId'])) {
            $model->reqId = $map['reqId'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
