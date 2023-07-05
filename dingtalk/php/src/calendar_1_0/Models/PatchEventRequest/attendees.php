<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventRequest;

use AlibabaCloud\Tea\Model;

class attendees extends Model
{
    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isOptional;
    protected $_name = [
        'email'      => 'email',
        'id'         => 'id',
        'isOptional' => 'isOptional',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isOptional) {
            $res['isOptional'] = $this->isOptional;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attendees
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isOptional'])) {
            $model->isOptional = $map['isOptional'];
        }

        return $model;
    }
}
