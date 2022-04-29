<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSubscribedCalendarResponseBody\subscribeScope;
use AlibabaCloud\Tea\Model;

class GetSubscribedCalendarResponseBody extends Model
{
    /**
     * @description 日历作者
     *
     * @var string
     */
    public $author;

    /**
     * @description 订阅日历id
     *
     * @var string
     */
    public $calendarId;

    /**
     * @description 日历描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 可管理人群
     *
     * @var string[]
     */
    public $managers;

    /**
     * @description 日历名
     *
     * @var string
     */
    public $name;

    /**
     * @description 可订阅范围
     *
     * @var subscribeScope
     */
    public $subscribeScope;
    protected $_name = [
        'author'         => 'author',
        'calendarId'     => 'calendarId',
        'description'    => 'description',
        'managers'       => 'managers',
        'name'           => 'name',
        'subscribeScope' => 'subscribeScope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->author) {
            $res['author'] = $this->author;
        }
        if (null !== $this->calendarId) {
            $res['calendarId'] = $this->calendarId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->managers) {
            $res['managers'] = $this->managers;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->subscribeScope) {
            $res['subscribeScope'] = null !== $this->subscribeScope ? $this->subscribeScope->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSubscribedCalendarResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['author'])) {
            $model->author = $map['author'];
        }
        if (isset($map['calendarId'])) {
            $model->calendarId = $map['calendarId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['managers'])) {
            if (!empty($map['managers'])) {
                $model->managers = $map['managers'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['subscribeScope'])) {
            $model->subscribeScope = subscribeScope::fromMap($map['subscribeScope']);
        }

        return $model;
    }
}
