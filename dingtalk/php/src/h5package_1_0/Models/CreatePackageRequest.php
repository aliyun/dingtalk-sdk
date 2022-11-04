<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatePackageRequest extends Model
{
    /**
     * @description 企业内部微应用agentId
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 第三方企业应用appId
     *
     * @var int
     */
    public $appId;

    /**
     * @description 离线包入口页面地址。没有设置时，默认值是应用设置中的应用首页地址。
     *
     * @var string
     */
    public $homeUrl;

    /**
     * @description 通过获取上传凭据接口返回的name值
     *
     * @var string
     */
    public $ossObjectKey;
    protected $_name = [
        'agentId'      => 'agentId',
        'appId'        => 'appId',
        'homeUrl'      => 'homeUrl',
        'ossObjectKey' => 'ossObjectKey',
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
