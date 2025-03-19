<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBindChildInfoResponseBody extends Model
{
    /**
     * @example 3000000000307711730
     *
     * @var string
     */
    public $childUserId;

    /**
     * @example 3000000000433459511
     *
     * @var string
     */
    public $currentUserId;

    /**
     * @example ding95eef8003c9ca8ca24f2f5cc6abecb85
     *
     * @var string
     */
    public $familyCorpId;
    protected $_name = [
        'childUserId' => 'childUserId',
        'currentUserId' => 'currentUserId',
        'familyCorpId' => 'familyCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->childUserId) {
            $res['childUserId'] = $this->childUserId;
        }
        if (null !== $this->currentUserId) {
            $res['currentUserId'] = $this->currentUserId;
        }
        if (null !== $this->familyCorpId) {
            $res['familyCorpId'] = $this->familyCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBindChildInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['childUserId'])) {
            $model->childUserId = $map['childUserId'];
        }
        if (isset($map['currentUserId'])) {
            $model->currentUserId = $map['currentUserId'];
        }
        if (isset($map['familyCorpId'])) {
            $model->familyCorpId = $map['familyCorpId'];
        }

        return $model;
    }
}
