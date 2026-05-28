<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListPendingPublishAuditsResponseBody\auditList;
use AlibabaCloud\Tea\Model;

class ListPendingPublishAuditsResponseBody extends Model
{
    /**
     * @var auditList[]
     */
    public $auditList;

    /**
     * @var string
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextPageToken;
    protected $_name = [
        'auditList' => 'auditList',
        'hasMore' => 'hasMore',
        'nextPageToken' => 'nextPageToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->auditList) {
            $res['auditList'] = [];
            if (null !== $this->auditList && \is_array($this->auditList)) {
                $n = 0;
                foreach ($this->auditList as $item) {
                    $res['auditList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextPageToken) {
            $res['nextPageToken'] = $this->nextPageToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPendingPublishAuditsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auditList'])) {
            if (!empty($map['auditList'])) {
                $model->auditList = [];
                $n = 0;
                foreach ($map['auditList'] as $item) {
                    $model->auditList[$n++] = null !== $item ? auditList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextPageToken'])) {
            $model->nextPageToken = $map['nextPageToken'];
        }

        return $model;
    }
}
