<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponseBody\users;
use AlibabaCloud\Tea\Model;

class SearchTeachersResponseBody extends Model
{
    /**
     * @var users[]
     */
    public $users;
    protected $_name = [
        'users' => 'users',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->users) {
            $res['users'] = [];
            if (null !== $this->users && \is_array($this->users)) {
                $n = 0;
                foreach ($this->users as $item) {
                    $res['users'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchTeachersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['users'])) {
            if (!empty($map['users'])) {
                $model->users = [];
                $n            = 0;
                foreach ($map['users'] as $item) {
                    $model->users[$n++] = null !== $item ? users::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
