<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses\subjectBaseInfoResponse;

use AlibabaCloud\Tea\Model;

class industryAll extends Model
{
    /**
     * @var string
     */
    public $category;

    /**
     * @var string
     */
    public $categoryBig;

    /**
     * @var string
     */
    public $categoryCodeFirst;

    /**
     * @var string
     */
    public $categoryCodeFourth;

    /**
     * @var string
     */
    public $categoryCodeSecond;

    /**
     * @var string
     */
    public $categoryCodeThird;

    /**
     * @var string
     */
    public $categoryMiddle;

    /**
     * @var string
     */
    public $categorySmall;
    protected $_name = [
        'category' => 'category',
        'categoryBig' => 'categoryBig',
        'categoryCodeFirst' => 'categoryCodeFirst',
        'categoryCodeFourth' => 'categoryCodeFourth',
        'categoryCodeSecond' => 'categoryCodeSecond',
        'categoryCodeThird' => 'categoryCodeThird',
        'categoryMiddle' => 'categoryMiddle',
        'categorySmall' => 'categorySmall',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->categoryBig) {
            $res['categoryBig'] = $this->categoryBig;
        }
        if (null !== $this->categoryCodeFirst) {
            $res['categoryCodeFirst'] = $this->categoryCodeFirst;
        }
        if (null !== $this->categoryCodeFourth) {
            $res['categoryCodeFourth'] = $this->categoryCodeFourth;
        }
        if (null !== $this->categoryCodeSecond) {
            $res['categoryCodeSecond'] = $this->categoryCodeSecond;
        }
        if (null !== $this->categoryCodeThird) {
            $res['categoryCodeThird'] = $this->categoryCodeThird;
        }
        if (null !== $this->categoryMiddle) {
            $res['categoryMiddle'] = $this->categoryMiddle;
        }
        if (null !== $this->categorySmall) {
            $res['categorySmall'] = $this->categorySmall;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return industryAll
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['categoryBig'])) {
            $model->categoryBig = $map['categoryBig'];
        }
        if (isset($map['categoryCodeFirst'])) {
            $model->categoryCodeFirst = $map['categoryCodeFirst'];
        }
        if (isset($map['categoryCodeFourth'])) {
            $model->categoryCodeFourth = $map['categoryCodeFourth'];
        }
        if (isset($map['categoryCodeSecond'])) {
            $model->categoryCodeSecond = $map['categoryCodeSecond'];
        }
        if (isset($map['categoryCodeThird'])) {
            $model->categoryCodeThird = $map['categoryCodeThird'];
        }
        if (isset($map['categoryMiddle'])) {
            $model->categoryMiddle = $map['categoryMiddle'];
        }
        if (isset($map['categorySmall'])) {
            $model->categorySmall = $map['categorySmall'];
        }

        return $model;
    }
}
