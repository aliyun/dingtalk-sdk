<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerAppResponseBody extends Model
{
    /**
     * @description 应用id
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 应用名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 应用描述
     *
     * @var string
     */
    public $desc;

    /**
     * @description 应用图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 应用移动端首页地址
     *
     * @var string
     */
    public $homepageLink;

    /**
     * @description 应用PC端首页地址
     *
     * @var string
     */
    public $pcHomepageLink;

    /**
     * @description 应用管理后台地址
     *
     * @var string
     */
    public $ompLink;

    /**
     * @description 应用的appkey
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 应用的secret
     *
     * @var string
     */
    public $appSecret;

    /**
     * @description 服务器出口ip
     *
     * @var string[]
     */
    public $ipWhiteList;
    protected $_name = [
        'agentId'        => 'agentId',
        'name'           => 'name',
        'desc'           => 'desc',
        'icon'           => 'icon',
        'homepageLink'   => 'homepageLink',
        'pcHomepageLink' => 'pcHomepageLink',
        'ompLink'        => 'ompLink',
        'appKey'         => 'appKey',
        'appSecret'      => 'appSecret',
        'ipWhiteList'    => 'ipWhiteList',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->homepageLink) {
            $res['homepageLink'] = $this->homepageLink;
        }
        if (null !== $this->pcHomepageLink) {
            $res['pcHomepageLink'] = $this->pcHomepageLink;
        }
        if (null !== $this->ompLink) {
            $res['ompLink'] = $this->ompLink;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->appSecret) {
            $res['appSecret'] = $this->appSecret;
        }
        if (null !== $this->ipWhiteList) {
            $res['ipWhiteList'] = $this->ipWhiteList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInnerAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['homepageLink'])) {
            $model->homepageLink = $map['homepageLink'];
        }
        if (isset($map['pcHomepageLink'])) {
            $model->pcHomepageLink = $map['pcHomepageLink'];
        }
        if (isset($map['ompLink'])) {
            $model->ompLink = $map['ompLink'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['appSecret'])) {
            $model->appSecret = $map['appSecret'];
        }
        if (isset($map['ipWhiteList'])) {
            if (!empty($map['ipWhiteList'])) {
                $model->ipWhiteList = $map['ipWhiteList'];
            }
        }

        return $model;
    }
}
