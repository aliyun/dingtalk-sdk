<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result;

use AlibabaCloud\Tea\Model;

class commentConf extends Model
{
    /**
     * @description 提示内容
     *
     * @var string
     */
    public $commentDescription;

    /**
     * @description 评论对发起人不可见
     *
     * @var bool
     */
    public $commentHiddenForProposer;

    /**
     * @description 评论必填
     *
     * @var bool
     */
    public $commentRequired;
    protected $_name = [
        'commentDescription'       => 'commentDescription',
        'commentHiddenForProposer' => 'commentHiddenForProposer',
        'commentRequired'          => 'commentRequired',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentDescription) {
            $res['commentDescription'] = $this->commentDescription;
        }
        if (null !== $this->commentHiddenForProposer) {
            $res['commentHiddenForProposer'] = $this->commentHiddenForProposer;
        }
        if (null !== $this->commentRequired) {
            $res['commentRequired'] = $this->commentRequired;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return commentConf
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentDescription'])) {
            $model->commentDescription = $map['commentDescription'];
        }
        if (isset($map['commentHiddenForProposer'])) {
            $model->commentHiddenForProposer = $map['commentHiddenForProposer'];
        }
        if (isset($map['commentRequired'])) {
            $model->commentRequired = $map['commentRequired'];
        }

        return $model;
    }
}
