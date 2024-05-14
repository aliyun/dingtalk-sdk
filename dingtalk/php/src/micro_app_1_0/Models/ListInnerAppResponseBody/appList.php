<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppResponseBody;

use AlibabaCloud\Tea\Model;

class appList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $agentId;

    /**
     * @example desc
     *
     * @var string
     */
    public $desc;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $homepageLink;

    /**
     * @example icon
     *
     * @var string
     */
    public $icon;

    /**
     * @example name
     *
     * @var string
     */
    public $name;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $ompLink;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $pcHomepageLink;
    protected $_name = [
        'agentId'        => 'agentId',
        'desc'           => 'desc',
        'homepageLink'   => 'homepageLink',
        'icon'           => 'icon',
        'name'           => 'name',
        'ompLink'        => 'ompLink',
        'pcHomepageLink' => 'pcHomepageLink',
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
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->homepageLink) {
            $res['homepageLink'] = $this->homepageLink;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ompLink) {
            $res['ompLink'] = $this->ompLink;
        }
        if (null !== $this->pcHomepageLink) {
            $res['pcHomepageLink'] = $this->pcHomepageLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['homepageLink'])) {
            $model->homepageLink = $map['homepageLink'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ompLink'])) {
            $model->ompLink = $map['ompLink'];
        }
        if (isset($map['pcHomepageLink'])) {
            $model->pcHomepageLink = $map['pcHomepageLink'];
        }

        return $model;
    }
}
