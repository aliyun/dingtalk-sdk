<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveAcrossCloudStroageConfigsResponseBody extends Model
{
    /**
     * @description 密匙ID
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description 存储域名地址
     *
     * @var string
     */
    public $endpoint;

    /**
     * @description 执行结果
     *
     * @var int
     */
    public $state;
    protected $_name = [
        'accessKeyId' => 'accessKeyId',
        'endpoint'    => 'endpoint',
        'state'       => 'state',
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
        if (null !== $this->endpoint) {
            $res['endpoint'] = $this->endpoint;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveAcrossCloudStroageConfigsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
