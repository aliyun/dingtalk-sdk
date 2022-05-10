<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageActiveStorageRequest extends Model
{
    /**
     * @description 密匙id
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description 密匙密码
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @description 带bucket的oss域名
     *
     * @var string
     */
    public $oss;

    /**
     * @description 企业id
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'accessKeyId'     => 'accessKeyId',
        'accessKeySecret' => 'accessKeySecret',
        'oss'             => 'oss',
        'targetCorpId'    => 'targetCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKeyId) {
            $res['accessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->accessKeySecret) {
            $res['accessKeySecret'] = $this->accessKeySecret;
        }
        if (null !== $this->oss) {
            $res['oss'] = $this->oss;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageActiveStorageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['accessKeySecret'])) {
            $model->accessKeySecret = $map['accessKeySecret'];
        }
        if (isset($map['oss'])) {
            $model->oss = $map['oss'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
