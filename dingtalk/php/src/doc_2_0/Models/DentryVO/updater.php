<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryVO;

use AlibabaCloud\Tea\Model;

class updater extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example DingTalk
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example YEp3JcM******UIbhwiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'name'    => 'name',
        'unionId' => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return updater
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
