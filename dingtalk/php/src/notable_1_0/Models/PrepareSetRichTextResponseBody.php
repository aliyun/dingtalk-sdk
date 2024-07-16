<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareSetRichTextResponseBody\uploadInfos;
use AlibabaCloud\Tea\Model;

class PrepareSetRichTextResponseBody extends Model
{
    /**
     * @var string
     */
    public $markdown;

    /**
     * @var uploadInfos[]
     */
    public $uploadInfos;
    protected $_name = [
        'markdown'    => 'markdown',
        'uploadInfos' => 'uploadInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->markdown) {
            $res['markdown'] = $this->markdown;
        }
        if (null !== $this->uploadInfos) {
            $res['uploadInfos'] = [];
            if (null !== $this->uploadInfos && \is_array($this->uploadInfos)) {
                $n = 0;
                foreach ($this->uploadInfos as $item) {
                    $res['uploadInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrepareSetRichTextResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['markdown'])) {
            $model->markdown = $map['markdown'];
        }
        if (isset($map['uploadInfos'])) {
            if (!empty($map['uploadInfos'])) {
                $model->uploadInfos = [];
                $n                  = 0;
                foreach ($map['uploadInfos'] as $item) {
                    $model->uploadInfos[$n++] = null !== $item ? uploadInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
