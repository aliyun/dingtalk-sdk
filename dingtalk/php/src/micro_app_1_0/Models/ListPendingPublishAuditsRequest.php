<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListPendingPublishAuditsRequest extends Model
{
    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var string
     */
    public $pageToken;
    protected $_name = [
        'pageSize' => 'pageSize',
        'pageToken' => 'pageToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageToken) {
            $res['pageToken'] = $this->pageToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPendingPublishAuditsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageToken'])) {
            $model->pageToken = $map['pageToken'];
        }

        return $model;
    }
}
