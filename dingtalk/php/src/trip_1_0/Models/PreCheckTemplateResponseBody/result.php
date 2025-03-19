<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateResponseBody\result\blockRecords;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var blockRecords[]
     */
    public $blockRecords;

    /**
     * @var bool
     */
    public $pass;
    protected $_name = [
        'blockRecords' => 'blockRecords',
        'pass' => 'pass',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->blockRecords) {
            $res['blockRecords'] = [];
            if (null !== $this->blockRecords && \is_array($this->blockRecords)) {
                $n = 0;
                foreach ($this->blockRecords as $item) {
                    $res['blockRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pass) {
            $res['pass'] = $this->pass;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blockRecords'])) {
            if (!empty($map['blockRecords'])) {
                $model->blockRecords = [];
                $n = 0;
                foreach ($map['blockRecords'] as $item) {
                    $model->blockRecords[$n++] = null !== $item ? blockRecords::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pass'])) {
            $model->pass = $map['pass'];
        }

        return $model;
    }
}
