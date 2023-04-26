<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataResponseBody;

use AlibabaCloud\Tea\Model;

class studyInfos extends Model
{
    /**
     * @example 10000
     *
     * @var int
     */
    public $durationMillis;

    /**
     * @example 16621*******284773
     *
     * @var string
     */
    public $uid;
    protected $_name = [
        'durationMillis' => 'durationMillis',
        'uid'            => 'uid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->durationMillis) {
            $res['durationMillis'] = $this->durationMillis;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studyInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['durationMillis'])) {
            $model->durationMillis = $map['durationMillis'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }

        return $model;
    }
}
