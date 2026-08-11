<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\justiceRisk;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\justiceRisk\subRisks\courtOpeningAnnouncement;
use AlibabaCloud\Tea\Model;

class subRisks extends Model
{
    /**
     * @var courtOpeningAnnouncement
     */
    public $courtOpeningAnnouncement;
    protected $_name = [
        'courtOpeningAnnouncement' => 'court_opening_announcement',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->courtOpeningAnnouncement) {
            $res['court_opening_announcement'] = null !== $this->courtOpeningAnnouncement ? $this->courtOpeningAnnouncement->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subRisks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['court_opening_announcement'])) {
            $model->courtOpeningAnnouncement = courtOpeningAnnouncement::fromMap($map['court_opening_announcement']);
        }

        return $model;
    }
}
