<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelRequest;

use AlibabaCloud\Tea\Model;

class roomConfig extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example name
     *
     * @var string
     */
    public $enName;

    /**
     * @description This parameter is required.
     *
     * @example www.xxx.com
     *
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example 栗子xx
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 30
     *
     * @var int
     */
    public $showTime;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $sort;

    /**
     * @description This parameter is required.
     *
     * @example https://www.taoxxx.com
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'enName' => 'enName',
        'icon' => 'icon',
        'name' => 'name',
        'showTime' => 'showTime',
        'sort' => 'sort',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enName) {
            $res['enName'] = $this->enName;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->showTime) {
            $res['showTime'] = $this->showTime;
        }
        if (null !== $this->sort) {
            $res['sort'] = $this->sort;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roomConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enName'])) {
            $model->enName = $map['enName'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['showTime'])) {
            $model->showTime = $map['showTime'];
        }
        if (isset($map['sort'])) {
            $model->sort = $map['sort'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
