<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileAttachmentQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileAttachmentQueryResponseBody\content\staffAttachmentInfoList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var staffAttachmentInfoList[]
     */
    public $staffAttachmentInfoList;
    protected $_name = [
        'staffAttachmentInfoList' => 'staffAttachmentInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->staffAttachmentInfoList) {
            $res['staffAttachmentInfoList'] = [];
            if (null !== $this->staffAttachmentInfoList && \is_array($this->staffAttachmentInfoList)) {
                $n = 0;
                foreach ($this->staffAttachmentInfoList as $item) {
                    $res['staffAttachmentInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['staffAttachmentInfoList'])) {
            if (!empty($map['staffAttachmentInfoList'])) {
                $model->staffAttachmentInfoList = [];
                $n = 0;
                foreach ($map['staffAttachmentInfoList'] as $item) {
                    $model->staffAttachmentInfoList[$n++] = null !== $item ? staffAttachmentInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
