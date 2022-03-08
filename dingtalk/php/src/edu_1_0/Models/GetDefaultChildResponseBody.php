<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponseBody\bindStudents;
use AlibabaCloud\Tea\Model;

class GetDefaultChildResponseBody extends Model
{
    /**
     * @var string
     */
    public $avatar;

    /**
     * @var bindStudents[]
     */
    public $bindStudents;

    /**
     * @var int
     */
    public $grade;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $period;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'avatar'       => 'avatar',
        'bindStudents' => 'bindStudents',
        'grade'        => 'grade',
        'name'         => 'name',
        'nick'         => 'nick',
        'period'       => 'period',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->bindStudents) {
            $res['bindStudents'] = [];
            if (null !== $this->bindStudents && \is_array($this->bindStudents)) {
                $n = 0;
                foreach ($this->bindStudents as $item) {
                    $res['bindStudents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->grade) {
            $res['grade'] = $this->grade;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDefaultChildResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['bindStudents'])) {
            if (!empty($map['bindStudents'])) {
                $model->bindStudents = [];
                $n                   = 0;
                foreach ($map['bindStudents'] as $item) {
                    $model->bindStudents[$n++] = null !== $item ? bindStudents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['grade'])) {
            $model->grade = $map['grade'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
