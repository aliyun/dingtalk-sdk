<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCollegeContactUserDetailRequest extends Model
{
    /**
     * @example 12122294
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example zhangsan666
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'jobNumber' => 'jobNumber',
        'language' => 'language',
        'userid' => 'userid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCollegeContactUserDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
