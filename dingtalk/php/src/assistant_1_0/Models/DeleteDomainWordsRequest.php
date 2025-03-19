<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteDomainWordsRequest\domainWords;
use AlibabaCloud\Tea\Model;

class DeleteDomainWordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

    /**
     * @description This parameter is required.
     *
     * @var domainWords[]
     */
    public $domainWords;
    protected $_name = [
        'assistantId' => 'assistantId',
        'domainWords' => 'domainWords',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->domainWords) {
            $res['domainWords'] = [];
            if (null !== $this->domainWords && \is_array($this->domainWords)) {
                $n = 0;
                foreach ($this->domainWords as $item) {
                    $res['domainWords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDomainWordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['domainWords'])) {
            if (!empty($map['domainWords'])) {
                $model->domainWords = [];
                $n = 0;
                foreach ($map['domainWords'] as $item) {
                    $model->domainWords[$n++] = null !== $item ? domainWords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
