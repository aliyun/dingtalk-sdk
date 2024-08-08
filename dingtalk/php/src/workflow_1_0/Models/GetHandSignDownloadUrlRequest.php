<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetHandSignDownloadUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example AzBltRlvKukX3Wxxxx
     *
     * @var string
     */
    public $handSignToken;

    /**
     * @description This parameter is required.
     *
     * @example ag187wewxxxx
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'handSignToken'     => 'handSignToken',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->handSignToken) {
            $res['handSignToken'] = $this->handSignToken;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetHandSignDownloadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['handSignToken'])) {
            $model->handSignToken = $map['handSignToken'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
