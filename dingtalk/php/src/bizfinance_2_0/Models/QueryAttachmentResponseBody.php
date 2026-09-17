<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAttachmentResponseBody\attachmentList;
use AlibabaCloud\Tea\Model;

class QueryAttachmentResponseBody extends Model
{
    /**
     * @var attachmentList[]
     */
    public $attachmentList;

    /**
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'attachmentList' => 'attachmentList',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentList) {
            $res['attachmentList'] = [];
            if (null !== $this->attachmentList && \is_array($this->attachmentList)) {
                $n = 0;
                foreach ($this->attachmentList as $item) {
                    $res['attachmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAttachmentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentList'])) {
            if (!empty($map['attachmentList'])) {
                $model->attachmentList = [];
                $n = 0;
                foreach ($map['attachmentList'] as $item) {
                    $model->attachmentList[$n++] = null !== $item ? attachmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
