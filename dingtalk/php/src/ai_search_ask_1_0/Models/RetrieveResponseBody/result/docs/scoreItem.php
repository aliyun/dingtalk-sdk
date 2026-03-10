<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\docs;

use AlibabaCloud\Tea\Model;

class scoreItem extends Model
{
    /**
     * @var float
     */
    public $finallyScore;

    /**
     * @var float[]
     */
    public $scoreMap;

    /**
     * @var float
     */
    public $scoreThreshold;

    /**
     * @var string[]
     */
    public $selectedBranch;

    /**
     * @var string
     */
    public $selectedCategory;
    protected $_name = [
        'finallyScore' => 'finallyScore',
        'scoreMap' => 'scoreMap',
        'scoreThreshold' => 'scoreThreshold',
        'selectedBranch' => 'selectedBranch',
        'selectedCategory' => 'selectedCategory',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->finallyScore) {
            $res['finallyScore'] = $this->finallyScore;
        }
        if (null !== $this->scoreMap) {
            $res['scoreMap'] = $this->scoreMap;
        }
        if (null !== $this->scoreThreshold) {
            $res['scoreThreshold'] = $this->scoreThreshold;
        }
        if (null !== $this->selectedBranch) {
            $res['selectedBranch'] = $this->selectedBranch;
        }
        if (null !== $this->selectedCategory) {
            $res['selectedCategory'] = $this->selectedCategory;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scoreItem
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['finallyScore'])) {
            $model->finallyScore = $map['finallyScore'];
        }
        if (isset($map['scoreMap'])) {
            $model->scoreMap = $map['scoreMap'];
        }
        if (isset($map['scoreThreshold'])) {
            $model->scoreThreshold = $map['scoreThreshold'];
        }
        if (isset($map['selectedBranch'])) {
            if (!empty($map['selectedBranch'])) {
                $model->selectedBranch = $map['selectedBranch'];
            }
        }
        if (isset($map['selectedCategory'])) {
            $model->selectedCategory = $map['selectedCategory'];
        }

        return $model;
    }
}
