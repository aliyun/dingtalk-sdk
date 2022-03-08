<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInnerAppRequest extends Model
{
    /**
     * @description 应用描述
     *
     * @var string
     */
    public $desc;

    /**
     * @description 应用首页地址
     *
     * @var string
     */
    public $homepageLink;

    /**
     * @description 应用图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 服务器出口ip白名单
     *
     * @var string[]
     */
    public $ipWhiteList;

    /**
     * @description 应用名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 应用管理后台地址
     *
     * @var string
     */
    public $ompLink;

    /**
     * @description 创建人unionId
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @description 应用PC端地址
     *
     * @var string
     */
    public $pcHomepageLink;
    protected $_name = [
        'desc'           => 'desc',
        'homepageLink'   => 'homepageLink',
        'icon'           => 'icon',
        'ipWhiteList'    => 'ipWhiteList',
        'name'           => 'name',
        'ompLink'        => 'ompLink',
        'opUnionId'      => 'opUnionId',
        'pcHomepageLink' => 'pcHomepageLink',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->homepageLink) {
            $res['homepageLink'] = $this->homepageLink;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->ipWhiteList) {
            $res['ipWhiteList'] = $this->ipWhiteList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ompLink) {
            $res['ompLink'] = $this->ompLink;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->pcHomepageLink) {
            $res['pcHomepageLink'] = $this->pcHomepageLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInnerAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['homepageLink'])) {
            $model->homepageLink = $map['homepageLink'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['ipWhiteList'])) {
            if (!empty($map['ipWhiteList'])) {
                $model->ipWhiteList = $map['ipWhiteList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ompLink'])) {
            $model->ompLink = $map['ompLink'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['pcHomepageLink'])) {
            $model->pcHomepageLink = $map['pcHomepageLink'];
        }

        return $model;
    }
}
