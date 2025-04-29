<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassRequest;

use AlibabaCloud\Tea\Model;

class openClass extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $classLevel;

    /**
     * @description This parameter is required.
     *
     * @example 熊猫班
     *
     * @var string
     */
    public $nick;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var string
     */
    public $onlyUseNick;
    protected $_name = [
        'classLevel' => 'classLevel',
        'nick' => 'nick',
        'onlyUseNick' => 'onlyUseNick',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classLevel) {
            $res['classLevel'] = $this->classLevel;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->onlyUseNick) {
            $res['onlyUseNick'] = $this->onlyUseNick;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openClass
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classLevel'])) {
            $model->classLevel = $map['classLevel'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['onlyUseNick'])) {
            $model->onlyUseNick = $map['onlyUseNick'];
        }

        return $model;
    }
}
