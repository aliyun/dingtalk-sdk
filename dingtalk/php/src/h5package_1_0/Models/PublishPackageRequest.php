<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishPackageRequest extends Model
{
    /**
     * @example 1234
     *
     * @var int
     */
    public $agentId;

    /**
     * @example 1234
     *
     * @var int
     */
    public $appId;

    /**
     * @example 0.0.1
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'agentId' => 'agentId',
        'appId'   => 'appId',
        'version' => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
