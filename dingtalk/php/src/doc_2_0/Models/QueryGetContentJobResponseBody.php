<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGetContentJobResponseBody extends Model
{
    /**
     * @var string
     */
    public $contentKey;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'contentKey' => 'contentKey',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentKey) {
            $res['contentKey'] = $this->contentKey;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGetContentJobResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentKey'])) {
            $model->contentKey = $map['contentKey'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
