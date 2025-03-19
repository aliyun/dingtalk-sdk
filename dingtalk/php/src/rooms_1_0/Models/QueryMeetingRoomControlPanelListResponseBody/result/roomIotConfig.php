<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListResponseBody\result;

use AlibabaCloud\Tea\Model;

class roomIotConfig extends Model
{
    /**
     * @example name
     *
     * @var string
     */
    public $enName;

    /**
     * @example https://www.taoxxxxx.com
     *
     * @var string
     */
    public $icon;

    /**
     * @example 栗子xx
     *
     * @var string
     */
    public $name;

    /**
     * @example 30
     *
     * @var int
     */
    public $showTime;

    /**
     * @example 0
     *
     * @var int
     */
    public $sort;

    /**
     * @example https://www.taoxxxxx.com
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
     * @return roomIotConfig
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
