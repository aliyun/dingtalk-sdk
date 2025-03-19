<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatePackageRequest extends Model
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
     * @example https://example.com/myapp/index.html
     *
     * @var string
     */
    public $homeUrl;

    /**
     * @example aaaaaa/bbbbbb
     *
     * @var string
     */
    public $ossObjectKey;
    protected $_name = [
        'agentId' => 'agentId',
        'appId' => 'appId',
        'homeUrl' => 'homeUrl',
        'ossObjectKey' => 'ossObjectKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->homeUrl) {
            $res['homeUrl'] = $this->homeUrl;
        }
        if (null !== $this->ossObjectKey) {
            $res['ossObjectKey'] = $this->ossObjectKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePackageRequest
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
        if (isset($map['homeUrl'])) {
            $model->homeUrl = $map['homeUrl'];
        }
        if (isset($map['ossObjectKey'])) {
            $model->ossObjectKey = $map['ossObjectKey'];
        }

        return $model;
    }
}
