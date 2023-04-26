<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageCheckConnectionRequest extends Model
{
    /**
     * @example sampleKeyId1234
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @example sampleSecretId1234
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @example https://oss.aliyuncs.com/bucket-name/
     *
     * @var string
     */
    public $oss;

    /**
     * @example dingxxxxxxxxxxxx
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
     * @return FileStorageCheckConnectionRequest
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
