<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCorrectStyleResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $checkSizeType;

    /**
     * @var string
     */
    public $halfCheckSizeType;

    /**
     * @var bool
     */
    public $showPaperScore;

    /**
     * @var string
     */
    public $subScoreDisplayType;

    /**
     * @var string
     */
    public $wrongSizeType;

    /**
     * @var string
     */
    public $wrongStyle;
    protected $_name = [
        'checkSizeType' => 'checkSizeType',
        'halfCheckSizeType' => 'halfCheckSizeType',
        'showPaperScore' => 'showPaperScore',
        'subScoreDisplayType' => 'subScoreDisplayType',
        'wrongSizeType' => 'wrongSizeType',
        'wrongStyle' => 'wrongStyle',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkSizeType) {
            $res['checkSizeType'] = $this->checkSizeType;
        }
        if (null !== $this->halfCheckSizeType) {
            $res['halfCheckSizeType'] = $this->halfCheckSizeType;
        }
        if (null !== $this->showPaperScore) {
            $res['showPaperScore'] = $this->showPaperScore;
        }
        if (null !== $this->subScoreDisplayType) {
            $res['subScoreDisplayType'] = $this->subScoreDisplayType;
        }
        if (null !== $this->wrongSizeType) {
            $res['wrongSizeType'] = $this->wrongSizeType;
        }
        if (null !== $this->wrongStyle) {
            $res['wrongStyle'] = $this->wrongStyle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkSizeType'])) {
            $model->checkSizeType = $map['checkSizeType'];
        }
        if (isset($map['halfCheckSizeType'])) {
            $model->halfCheckSizeType = $map['halfCheckSizeType'];
        }
        if (isset($map['showPaperScore'])) {
            $model->showPaperScore = $map['showPaperScore'];
        }
        if (isset($map['subScoreDisplayType'])) {
            $model->subScoreDisplayType = $map['subScoreDisplayType'];
        }
        if (isset($map['wrongSizeType'])) {
            $model->wrongSizeType = $map['wrongSizeType'];
        }
        if (isset($map['wrongStyle'])) {
            $model->wrongStyle = $map['wrongStyle'];
        }

        return $model;
    }
}
