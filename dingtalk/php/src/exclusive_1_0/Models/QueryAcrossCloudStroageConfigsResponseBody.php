<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcrossCloudStroageConfigsResponseBody extends Model
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
     * @description bucket名称
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description 云厂商类型
     *
     * @var int
     */
    public $cloudType;

    /**
     * @description 存储域名地址
     *
     * @var string
     */
    public $endpoint;
    protected $_name = [
        'accessKeyId'     => 'accessKeyId',
        'accessKeySecret' => 'accessKeySecret',
        'bucketName'      => 'bucketName',
        'cloudType'       => 'cloudType',
        'endpoint'        => 'endpoint',
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
        if (null !== $this->bucketName) {
            $res['bucketName'] = $this->bucketName;
        }
        if (null !== $this->cloudType) {
            $res['cloudType'] = $this->cloudType;
        }
        if (null !== $this->endpoint) {
            $res['endpoint'] = $this->endpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAcrossCloudStroageConfigsResponseBody
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
        if (isset($map['bucketName'])) {
            $model->bucketName = $map['bucketName'];
        }
        if (isset($map['cloudType'])) {
            $model->cloudType = $map['cloudType'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }

        return $model;
    }
}
