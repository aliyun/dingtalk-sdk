<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDevelopersRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $noticeUrl;
    protected $_name = [
        'dingCorpId' => 'dingCorpId',
        'noticeUrl'  => 'noticeUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->noticeUrl) {
            $res['noticeUrl'] = $this->noticeUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDevelopersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['noticeUrl'])) {
            $model->noticeUrl = $map['noticeUrl'];
        }

        return $model;
    }
}
