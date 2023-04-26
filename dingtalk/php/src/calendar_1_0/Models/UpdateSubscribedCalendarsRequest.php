<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UpdateSubscribedCalendarsRequest\subscribeScope;
use AlibabaCloud\Tea\Model;

class UpdateSubscribedCalendarsRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string[]
     */
    public $managers;

    /**
     * @var string
     */
    public $name;

    /**
     * @var subscribeScope
     */
    public $subscribeScope;
    protected $_name = [
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
     * @return UpdateSubscribedCalendarsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
