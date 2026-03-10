<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveRequest\dragRequestContext;

use AlibabaCloud\Tea\Model;

class evaluationContext extends Model
{
    /**
     * @var string
     */
    public $sourceDentryId;
    protected $_name = [
        'sourceDentryId' => 'sourceDentryId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceDentryId) {
            $res['sourceDentryId'] = $this->sourceDentryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return evaluationContext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceDentryId'])) {
            $model->sourceDentryId = $map['sourceDentryId'];
        }

        return $model;
    }
}
