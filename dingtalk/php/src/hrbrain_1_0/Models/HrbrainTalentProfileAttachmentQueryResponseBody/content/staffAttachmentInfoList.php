<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileAttachmentQueryResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileAttachmentQueryResponseBody\content\staffAttachmentInfoList\attachmentInfoList;
use AlibabaCloud\Tea\Model;

class staffAttachmentInfoList extends Model
{
    /**
     * @var attachmentInfoList[]
     */
    public $attachmentInfoList;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'attachmentInfoList' => 'attachmentInfoList',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentInfoList) {
            $res['attachmentInfoList'] = [];
            if (null !== $this->attachmentInfoList && \is_array($this->attachmentInfoList)) {
                $n = 0;
                foreach ($this->attachmentInfoList as $item) {
                    $res['attachmentInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return staffAttachmentInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentInfoList'])) {
            if (!empty($map['attachmentInfoList'])) {
                $model->attachmentInfoList = [];
                $n = 0;
                foreach ($map['attachmentInfoList'] as $item) {
                    $model->attachmentInfoList[$n++] = null !== $item ? attachmentInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
