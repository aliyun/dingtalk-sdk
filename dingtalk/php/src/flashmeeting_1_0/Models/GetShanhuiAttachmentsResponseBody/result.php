<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiAttachmentsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiAttachmentsResponseBody\result\attachments;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;
    protected $_name = [
        'attachments' => 'attachments',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
