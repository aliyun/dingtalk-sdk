<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardRequest;

use AlibabaCloud\Tea\Model;

class cardUpdateOptions extends Model
{
    /**
     * @description 按 key 更新 cardData 数据，不填默认覆盖更新。
     *
     * @var bool
     */
    public $updateCardDataByKey;

    /**
     * @description 【可选】按key更新privateData用户数据，不填默认覆盖更新。
     *
     * @var bool
     */
    public $updatePrivateDataByKey;
    protected $_name = [
        'updateCardDataByKey'    => 'updateCardDataByKey',
        'updatePrivateDataByKey' => 'updatePrivateDataByKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateCardDataByKey) {
            $res['updateCardDataByKey'] = $this->updateCardDataByKey;
        }
        if (null !== $this->updatePrivateDataByKey) {
            $res['updatePrivateDataByKey'] = $this->updatePrivateDataByKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardUpdateOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updateCardDataByKey'])) {
            $model->updateCardDataByKey = $map['updateCardDataByKey'];
        }
        if (isset($map['updatePrivateDataByKey'])) {
            $model->updatePrivateDataByKey = $map['updatePrivateDataByKey'];
        }

        return $model;
    }
}
