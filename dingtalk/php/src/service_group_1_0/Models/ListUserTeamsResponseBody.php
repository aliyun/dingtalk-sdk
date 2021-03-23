<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsResponseBody\teams;
use AlibabaCloud\Tea\Model;

class ListUserTeamsResponseBody extends Model
{
    /**
     * @description teams
     *
     * @var teams[]
     */
    public $teams;
    protected $_name = [
        'teams' => 'teams',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->teams) {
            $res['teams'] = [];
            if (null !== $this->teams && \is_array($this->teams)) {
                $n = 0;
                foreach ($this->teams as $item) {
                    $res['teams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserTeamsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['teams'])) {
            if (!empty($map['teams'])) {
                $model->teams = [];
                $n            = 0;
                foreach ($map['teams'] as $item) {
                    $model->teams[$n++] = null !== $item ? teams::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
