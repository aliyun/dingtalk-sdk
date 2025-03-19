<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardWithDelegateRequest;

use AlibabaCloud\Tea\Model;

class imSingleOpenDeliverModel extends Model
{
    /**
     * @var string[]
     */
    public $atUserIds;

    /**
     * @var string[]
     */
    public $extension;
    protected $_name = [
        'atUserIds' => 'atUserIds',
        'extension' => 'extension',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUserIds) {
            $res['atUserIds'] = $this->atUserIds;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return imSingleOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUserIds'])) {
            $model->atUserIds = $map['atUserIds'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }

        return $model;
    }
}
