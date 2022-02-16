<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateResponseBody\recallResult;
use AlibabaCloud\Tea\Model;

class RecallAuditTemplateResponseBody extends Model
{
    /**
     * @var recallResult[]
     */
    public $recallResult;
    protected $_name = [
        'recallResult' => 'recallResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recallResult) {
            $res['recallResult'] = [];
            if (null !== $this->recallResult && \is_array($this->recallResult)) {
                $n = 0;
                foreach ($this->recallResult as $item) {
                    $res['recallResult'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecallAuditTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recallResult'])) {
            if (!empty($map['recallResult'])) {
                $model->recallResult = [];
                $n                   = 0;
                foreach ($map['recallResult'] as $item) {
                    $model->recallResult[$n++] = null !== $item ? recallResult::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
