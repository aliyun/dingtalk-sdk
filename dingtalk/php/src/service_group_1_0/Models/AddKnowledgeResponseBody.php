<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddKnowledgeResponseBody extends Model
{
    /**
     * @example J23suw1irs
     *
     * @var string
     */
    public $openKnowledgeId;
    protected $_name = [
        'openKnowledgeId' => 'openKnowledgeId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openKnowledgeId) {
            $res['openKnowledgeId'] = $this->openKnowledgeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddKnowledgeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openKnowledgeId'])) {
            $model->openKnowledgeId = $map['openKnowledgeId'];
        }

        return $model;
    }
}
