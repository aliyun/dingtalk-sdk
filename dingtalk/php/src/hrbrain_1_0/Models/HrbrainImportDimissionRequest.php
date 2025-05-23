<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDimissionRequest\body;
use AlibabaCloud\Tea\Model;

class HrbrainImportDimissionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var body[]
     */
    public $body;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'body' => 'body',
        'corpId' => 'corpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = [];
            if (null !== $this->body && \is_array($this->body)) {
                $n = 0;
                foreach ($this->body as $item) {
                    $res['body'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainImportDimissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            if (!empty($map['body'])) {
                $model->body = [];
                $n = 0;
                foreach ($map['body'] as $item) {
                    $model->body[$n++] = null !== $item ? body::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
