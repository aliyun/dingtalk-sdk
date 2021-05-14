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
    public $name;

    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $period;

    /**
     * @var int
     */
    public $grade;

    /**
     * @var bindStudents[]
     */
    public $bindStudents;
    protected $_name = [
        'name'         => 'name',
        'nick'         => 'nick',
        'avatar'       => 'avatar',
        'unionId'      => 'unionId',
        'period'       => 'period',
        'grade'        => 'grade',
        'bindStudents' => 'bindStudents',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->grade) {
            $res['grade'] = $this->grade;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['grade'])) {
            $model->grade = $map['grade'];
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

        return $model;
    }
}
