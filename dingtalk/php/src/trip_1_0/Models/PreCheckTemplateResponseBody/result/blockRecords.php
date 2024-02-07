<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateResponseBody\result;

use AlibabaCloud\Tea\Model;

class blockRecords extends Model
{
    /**
     * @var string
     */
    public $blockType;

    /**
     * @var string
     */
    public $reason;
    protected $_name = [
        'blockType' => 'blockType',
        'reason'    => 'reason',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blockType) {
            $res['blockType'] = $this->blockType;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return blockRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blockType'])) {
            $model->blockType = $map['blockType'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }

        return $model;
    }
}
