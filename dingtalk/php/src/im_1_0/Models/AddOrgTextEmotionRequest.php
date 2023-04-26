<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOrgTextEmotionRequest extends Model
{
    /**
     * @example @123xxx
     *
     * @var string
     */
    public $backgroundMediaId;

    /**
     * @example @345xxx
     *
     * @var string
     */
    public $backgroundMediaIdForPanel;

    /**
     * @example -1
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 企业表情1
     *
     * @var string
     */
    public $emotionName;
    protected $_name = [
        'backgroundMediaId'         => 'backgroundMediaId',
        'backgroundMediaIdForPanel' => 'backgroundMediaIdForPanel',
        'deptId'                    => 'deptId',
        'emotionName'               => 'emotionName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundMediaId) {
            $res['backgroundMediaId'] = $this->backgroundMediaId;
        }
        if (null !== $this->backgroundMediaIdForPanel) {
            $res['backgroundMediaIdForPanel'] = $this->backgroundMediaIdForPanel;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOrgTextEmotionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundMediaId'])) {
            $model->backgroundMediaId = $map['backgroundMediaId'];
        }
        if (isset($map['backgroundMediaIdForPanel'])) {
            $model->backgroundMediaIdForPanel = $map['backgroundMediaIdForPanel'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }

        return $model;
    }
}
