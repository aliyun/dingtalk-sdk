<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcredit_1_0\Models\QueryScoreResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var float
     */
    public $ccocScore;

    /**
     * @var int
     */
    public $cityChangeCnt3y;

    /**
     * @var float
     */
    public $cityChangeTrend2y;

    /**
     * @var string
     */
    public $classificationOfOrg;

    /**
     * @var float
     */
    public $growthRateLoginDays180d;

    /**
     * @var int
     */
    public $indChangeCnt3y;

    /**
     * @var float
     */
    public $indChangeTrend2y;

    /**
     * @var int
     */
    public $jobChangeCnt3y;

    /**
     * @var string
     */
    public $jobTitle;

    /**
     * @var int
     */
    public $joinDays;

    /**
     * @var float
     */
    public $loginDays14dPct;

    /**
     * @var float
     */
    public $loginDays365dPct;

    /**
     * @var int
     */
    public $orgCnt;

    /**
     * @var string
     */
    public $orgIndustrySubNameNew;

    /**
     * @var string
     */
    public $orgIndustryUpNameNew;
    protected $_name = [
        'ccocScore' => 'ccocScore',
        'cityChangeCnt3y' => 'cityChangeCnt3y',
        'cityChangeTrend2y' => 'cityChangeTrend2y',
        'classificationOfOrg' => 'classificationOfOrg',
        'growthRateLoginDays180d' => 'growthRateLoginDays180d',
        'indChangeCnt3y' => 'indChangeCnt3y',
        'indChangeTrend2y' => 'indChangeTrend2y',
        'jobChangeCnt3y' => 'jobChangeCnt3y',
        'jobTitle' => 'jobTitle',
        'joinDays' => 'joinDays',
        'loginDays14dPct' => 'loginDays14dPct',
        'loginDays365dPct' => 'loginDays365dPct',
        'orgCnt' => 'orgCnt',
        'orgIndustrySubNameNew' => 'orgIndustrySubNameNew',
        'orgIndustryUpNameNew' => 'orgIndustryUpNameNew',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ccocScore) {
            $res['ccocScore'] = $this->ccocScore;
        }
        if (null !== $this->cityChangeCnt3y) {
            $res['cityChangeCnt3y'] = $this->cityChangeCnt3y;
        }
        if (null !== $this->cityChangeTrend2y) {
            $res['cityChangeTrend2y'] = $this->cityChangeTrend2y;
        }
        if (null !== $this->classificationOfOrg) {
            $res['classificationOfOrg'] = $this->classificationOfOrg;
        }
        if (null !== $this->growthRateLoginDays180d) {
            $res['growthRateLoginDays180d'] = $this->growthRateLoginDays180d;
        }
        if (null !== $this->indChangeCnt3y) {
            $res['indChangeCnt3y'] = $this->indChangeCnt3y;
        }
        if (null !== $this->indChangeTrend2y) {
            $res['indChangeTrend2y'] = $this->indChangeTrend2y;
        }
        if (null !== $this->jobChangeCnt3y) {
            $res['jobChangeCnt3y'] = $this->jobChangeCnt3y;
        }
        if (null !== $this->jobTitle) {
            $res['jobTitle'] = $this->jobTitle;
        }
        if (null !== $this->joinDays) {
            $res['joinDays'] = $this->joinDays;
        }
        if (null !== $this->loginDays14dPct) {
            $res['loginDays14dPct'] = $this->loginDays14dPct;
        }
        if (null !== $this->loginDays365dPct) {
            $res['loginDays365dPct'] = $this->loginDays365dPct;
        }
        if (null !== $this->orgCnt) {
            $res['orgCnt'] = $this->orgCnt;
        }
        if (null !== $this->orgIndustrySubNameNew) {
            $res['orgIndustrySubNameNew'] = $this->orgIndustrySubNameNew;
        }
        if (null !== $this->orgIndustryUpNameNew) {
            $res['orgIndustryUpNameNew'] = $this->orgIndustryUpNameNew;
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
        if (isset($map['ccocScore'])) {
            $model->ccocScore = $map['ccocScore'];
        }
        if (isset($map['cityChangeCnt3y'])) {
            $model->cityChangeCnt3y = $map['cityChangeCnt3y'];
        }
        if (isset($map['cityChangeTrend2y'])) {
            $model->cityChangeTrend2y = $map['cityChangeTrend2y'];
        }
        if (isset($map['classificationOfOrg'])) {
            $model->classificationOfOrg = $map['classificationOfOrg'];
        }
        if (isset($map['growthRateLoginDays180d'])) {
            $model->growthRateLoginDays180d = $map['growthRateLoginDays180d'];
        }
        if (isset($map['indChangeCnt3y'])) {
            $model->indChangeCnt3y = $map['indChangeCnt3y'];
        }
        if (isset($map['indChangeTrend2y'])) {
            $model->indChangeTrend2y = $map['indChangeTrend2y'];
        }
        if (isset($map['jobChangeCnt3y'])) {
            $model->jobChangeCnt3y = $map['jobChangeCnt3y'];
        }
        if (isset($map['jobTitle'])) {
            $model->jobTitle = $map['jobTitle'];
        }
        if (isset($map['joinDays'])) {
            $model->joinDays = $map['joinDays'];
        }
        if (isset($map['loginDays14dPct'])) {
            $model->loginDays14dPct = $map['loginDays14dPct'];
        }
        if (isset($map['loginDays365dPct'])) {
            $model->loginDays365dPct = $map['loginDays365dPct'];
        }
        if (isset($map['orgCnt'])) {
            $model->orgCnt = $map['orgCnt'];
        }
        if (isset($map['orgIndustrySubNameNew'])) {
            $model->orgIndustrySubNameNew = $map['orgIndustrySubNameNew'];
        }
        if (isset($map['orgIndustryUpNameNew'])) {
            $model->orgIndustryUpNameNew = $map['orgIndustryUpNameNew'];
        }

        return $model;
    }
}
