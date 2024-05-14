<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GrantProcessInstanceForDownloadFileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var string
     */
    public $fileId;

    /**
     * @description This parameter is required.
     *
     * @example a17444d1-075b-4a4d-xxxx
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'fileId'            => 'fileId',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GrantProcessInstanceForDownloadFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
