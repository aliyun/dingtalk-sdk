<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveStorageSwitchRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0-关闭，1-开启
     *
     * @var int
     */
    public $openStorage;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'openStorage' => 'openStorage',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openStorage) {
            $res['openStorage'] = $this->openStorage;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveStorageSwitchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openStorage'])) {
            $model->openStorage = $map['openStorage'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
