<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedTaskRequest;

use AlibabaCloud\Tea\Model;

class taskConfig extends Model
{
    /**
     * @var bool
     */
    public $disableSendCard;
    protected $_name = [
        'disableSendCard' => 'disableSendCard',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->disableSendCard) {
            $res['disableSendCard'] = $this->disableSendCard;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return taskConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['disableSendCard'])) {
            $model->disableSendCard = $map['disableSendCard'];
        }

        return $model;
    }
}
